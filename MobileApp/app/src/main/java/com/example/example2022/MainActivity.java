package com.example.example2022;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.util.Locale;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void convertCurrency(View v)
    {
        EditText dollarText = findViewById(R.id.dollarText);
        TextView euroText = findViewById(R.id.euroTV);

        if(!dollarText.getText().toString().equals(""))
        {
            float dollarValue = Float.parseFloat(dollarText.getText().toString());
            float euroValue = dollarValue * 0.85F;

            euroText.setText(String.format(Locale.ENGLISH, "%.2f", euroValue));
        }
        else
        {
            euroText.setText(R.string.no_value_string);
        }
    }
}