package com.example.viewmodeldemo.ui.main;

import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProvider;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.viewmodeldemo.R;
import com.example.viewmodeldemo.databinding.MainFragmentBinding;

import java.util.Locale;

public class MainFragment extends Fragment {

    private MainViewModel mViewModel;
    private MainFragmentBinding binding;

    public static MainFragment newInstance() {
        return new MainFragment();
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container,
                             @Nullable Bundle savedInstanceState) {
        //return inflater.inflate(R.layout.main_fragment, container, false); OLD WAY

        binding = MainFragmentBinding.inflate(inflater, container, false);//NEW WAY Implements the view binding
        return binding.getRoot();
    }

    @Override
    public void onDestroyView() //What to do when the fragment is destroyed
    {
        super.onDestroyView();
        binding = null;
    }



    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);
        mViewModel = new ViewModelProvider(this).get(MainViewModel.class);//Connects this to the view model

        /*
        binding.euroText.setText(String.format(Locale.ENGLISH, "%.2F", mViewModel.getResult()));

        final Observer<Float> resultObserver = new Observer<Float>() {
            @Override
            public void onChanged(@Nullable final Float result) {
                binding.euroText.setText(String.format(Locale.ENGLISH, "%.2f", result));
            }
        };

        mViewModel.getResult().observe(getViewLifecycleOwner(), resultObserver);

        binding.convertBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(!binding.dollarText.getText().toString().equals(""))
                {
                    mViewModel.setAmount(String.format(String.format(Locale.ENGLISH, "%s", binding.dollarText.getText())));
                    binding.euroText.setText(String.format(Locale.ENGLISH, "%.2F", mViewModel.getResult()));
                }
                else
                {
                    binding.euroText.setText("No Value");
                }
            }
        });*/
    }
}