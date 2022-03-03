package com.example.viewmodeldemo.ui.main;

import androidx.lifecycle.MutableLiveData;

import androidx.lifecycle.ViewModel;

public class MainViewModel extends ViewModel {

    //Variable declarations
    private static final float rate = 0.87F;
    public MutableLiveData<String> dollarValue = new MutableLiveData<>();
    public MutableLiveData<Float> result = new MutableLiveData<>();

    //Method to get input and assign to dollarText
    /*public void setAmount(String value)           Not needed cause of data binding
    {
        this.dollarText = value;
        result.setValue(Float.parseFloat(dollarText) * rate);
    }

    //Method to return the result for use
    public MutableLiveData<Float> getResult()
    {
        return result;
    }*/
}