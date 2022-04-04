package com.example.tablayoutexample;

import android.os.Bundle;

import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;

import android.view.View;

//Navigation stuff
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

//Tab layout stuff
import com.example.tablayoutexample.databinding.ActivityMainBinding;

import android.view.Menu;
import android.view.MenuItem;

//Notification stuff
import android.app.NotificationManager;
import android.app.NotificationChannel;
import android.content.Context;
import android.graphics.Color;
import android.app.Notification;

//Notification:Start app
import android.app.PendingIntent;
import android.content.Intent;
import android.graphics.drawable.Icon;


import android.net.Uri;
import androidx.viewpager2.adapter.FragmentStateAdapter;
import com.google.android.material.tabs.TabLayoutMediator;
import com.google.android.material.tabs.TabLayout;

public class MainActivity extends AppCompatActivity {

    private AppBarConfiguration appBarConfiguration;
    private ActivityMainBinding binding;
    NotificationManager nm;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        setSupportActionBar(binding.toolbar);

        binding.fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        //Stab layout stuff
        configureTabLayout();

        //Notification stuff
        nm = (NotificationManager) getSystemService(Context.NOTIFICATION_SERVICE);

        createNotificationChannel("com.example.tablayoutexample.news", "Bruh, listen!", "Hey, Bruh!");
        sendNotification(findViewById(R.id.view_pager));
    }

    protected void configureTabLayout()
    {
        for (int i = 0; i < 4; i++)
        {
            binding.tabLayout.addTab(binding.tabLayout.newTab());
        }
        final FragmentStateAdapter adapter = new TabStateAdapter(this, binding.tabLayout.getTabCount());
        binding.viewPager.setAdapter(adapter);
        new TabLayoutMediator(binding.tabLayout, binding.viewPager, (tab, position) -> tab.setText("Tab " + (position + 1) + " item")).attach();
    }

    protected void createNotificationChannel(String id, String name, String description)
    {
        int importance = NotificationManager.IMPORTANCE_HIGH;

        NotificationChannel channel = new NotificationChannel(id, name, importance);



        channel.setDescription(description);
        channel.enableLights(true);
        channel.setLightColor(Color.MAGENTA);
        channel.setVibrationPattern(new long[]{100, 200, 300, 400, 500, 400, 200, 400});
        nm.createNotificationChannel(channel);
    }

    public void sendNotification(View view)
    {
        int notificationID = 101;
        Intent resultIntent = new Intent(this, Bructivity.class);
        String channelID = "com.example.tablayoutexample.news";
        final Icon icon = Icon.createWithResource(MainActivity.this, android.R.drawable.ic_dialog_info);


        PendingIntent pendingIntent = PendingIntent.getActivity(this, 0, resultIntent,PendingIntent.FLAG_UPDATE_CURRENT);

        Notification.Action action = new Notification.Action.Builder(icon, "Open", pendingIntent).build();

        Notification notification = new Notification.Builder(MainActivity.this, channelID)
                .setContentTitle("ExampleNotification")
                .setContentText("This is an example")
                .setSmallIcon(android.R.drawable.ic_dialog_info)
                .setChannelId(channelID)
                .setContentIntent(pendingIntent)
                .setActions(action)
                .build();

        nm.notify(notificationID, notification);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}