package com.example.tabbedactivity;

import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.viewpager2.adapter.FragmentStateAdapter;

public class TabStateAdapter extends FragmentStateAdapter{
    int tabCount;

    public TabStateAdapter(FragmentActivity fa, int numberOfTabs)
    {
        super(fa);
        this.tabCount = numberOfTabs;
    }

    @Override
    public Fragment createFragment(int position)
    {
        switch (position)
        {
            case 0:
                return new Fragment_1();
            case 1:
                return new Fragment_2();
            case 2:
                return new Fragment_3();
            default:
                return null;
        }
    }

    @Override
    public int getItemCount()
    {
        return tabCount;
    }
}
