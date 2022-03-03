package com.example.tablayoutexample;

import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.viewpager2.adapter.FragmentStateAdapter;

public class TabStateAdapter extends FragmentStateAdapter{
    int tabCount;

    public TabStateAdapter(FragmentActivity fa, int numTabs)
    {
        super(fa);
        this.tabCount = numTabs;
    }

    @Override
    public Fragment createFragment(int position)
    {
        switch(position)
        {
            case 0:
                return new Tab1Fragment();
            case 1:
                return new Tab2Fragment();
            case 2:
                return new Tab3Fragment();
            case 3:
                return new Tab4Fragment();
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
