package com.example.mycalc

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.TextView

class MainActivity : AppCompatActivity() {

    private var displayTV: TextView? = null
    private var lastNum: Boolean = false
    //private var oneBtn: Button? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        //links our local variable of displayTV to the buttons?
        displayTV = findViewById(R.id.displayTV)

        //oneBtn = findViewById(R.id.oneBtn)
        //oneBtn?.setOnClickListener{displayTV?.append("1")}
    }

    fun onDigit(view: View)
    {
        displayTV?.append((view as Button).text)
        lastNum = true
    }

    fun onClear(view: View)
    {
        displayTV?.text = ""
        lastNum = false
    }

    fun onDecimal(view: View)
    {
        //check if displayTV is there, and if the text has a value
        displayTV?.text.let {
            if (hasOperator(it.toString()))
            {
                val numStr = it.toString().split('+', '-', '*', '/')[1]

                if (lastNum && numStr.contains('.'))
                {
                    displayTV?.append(".")
                    lastNum = false
                }
                else if (numStr.isEmpty())
                {
                    displayTV?.append("0.")
                    lastNum = false
                }
            }
            else if (lastNum && !it.toString().contains('.'))
            {
                displayTV?.append(".")
                lastNum = false
            }
            else if (it.toString().isEmpty())
            {
                displayTV?.append("0.")
                lastNum = false
            }
        }
    }

    fun onOperator(view: View)
    {
        displayTV?.text?.let {
            if (lastNum && !(hasOperator(it.toString())))
            {
                displayTV?.append((view as Button).text)
                lastNum = false
            }
        }
    }

    fun onEqual(view: View)
    {
        if (lastNum)
        {
            var expr = displayTV?.text.toString()

            try {
                //check addition
                if (expr.contains('+'))
                {
                    val splitExpr = expr.split('+')

                    displayTV?.text = removeTrailingZero((splitExpr[0].toDouble() + splitExpr[1].toDouble()).toString())
                }
                //check subtraction
                else if (expr.contains('-'))
                {
                    val splitExpr = expr.split('-')

                    displayTV?.text = removeTrailingZero((splitExpr[0].toDouble() - splitExpr[1].toDouble()).toString())
                }
                //check multiplication
                else if (expr.contains('*'))
                {
                    val splitExpr = expr.split('*')

                    displayTV?.text = removeTrailingZero((splitExpr[0].toDouble() * splitExpr[1].toDouble()).toString())
                }
                //check division
                if (expr.contains('/'))
                {
                    val splitExpr = expr.split('/')

                    displayTV?.text = removeTrailingZero((splitExpr[0].toDouble() / splitExpr[1].toDouble()).toString())
                }
            }catch (e: ArithmeticException)
            {
                e.printStackTrace()
            }
        }
    }

    private fun removeTrailingZero(result: String): String
    {
        return if (result.endsWith(".0"))
        {
            result.substring(0, result.length - 2)
        }
        else
        {
            result
        }
    }

    private fun hasOperator(value: String): Boolean
    {
        return if (value.endsWith('-')) {
            false
        }
        else {
            value.contains('/')
                    || value.contains('*')
                    || value.contains('+')
                    || value.contains('-')
        }
    }
}