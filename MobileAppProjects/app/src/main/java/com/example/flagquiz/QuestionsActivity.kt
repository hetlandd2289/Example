package com.example.flagquiz

import android.content.Intent
import android.graphics.Color
import android.graphics.Typeface
import android.graphics.drawable.AdaptiveIconDrawable
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.ImageView
import android.widget.ProgressBar
import android.widget.TextView
import android.view.View
import androidx.core.content.ContextCompat

class QuestionsActivity : AppCompatActivity(), View.OnClickListener {

    private var username: String? = null

    private var currentPosition: Int = 1
    private var questionsList: ArrayList<Question>? = null
    private var selectedOptionPosition: Int = 0
    private var correctAnswers: Int = 0

    private var questionTV: TextView? = null
    private var flagIV: ImageView? = null
    private var progressPB: ProgressBar? = null
    private var progressTV: TextView? = null
    private var questionOneTV: TextView? = null
    private var questionTwoTV: TextView? = null
    private var questionThreeTV: TextView? = null
    private var questionFourTV: TextView? = null
    private var submitBtn: Button? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_questions)

        username = intent.getStringExtra(Constants.USERNAME)

        //bind all controls to the created variables
        questionTV = findViewById(R.id.questionTV)
        flagIV = findViewById(R.id.flagIV)
        progressPB = findViewById(R.id.progressBar)
        progressTV = findViewById(R.id.progressTV)
        questionOneTV = findViewById(R.id.optionOneTV)
        questionTwoTV = findViewById(R.id.optionTwoTV)
        questionThreeTV = findViewById(R.id.optionThreeTV)
        questionFourTV = findViewById(R.id.optionFourTV)
        submitBtn = findViewById(R.id.submitButton)

        //add on click listeners
        questionOneTV?.setOnClickListener(this)
        questionTwoTV?.setOnClickListener(this)
        questionThreeTV?.setOnClickListener(this)
        questionFourTV?.setOnClickListener(this)
        submitBtn?.setOnClickListener(this)

        questionsList = Constants.getQuestions()

        setQuestion()
    }

    private fun setQuestion() {
        defaultOptionsView()
        val question: Question = questionsList!![currentPosition - 1]

        //set up the question
        questionTV?.text = question.question
        flagIV?.setImageResource(question.image)
        progressPB?.progress = currentPosition
        progressTV?.text = "$currentPosition / ${progressPB?.max}"

        //set up the answers
        questionOneTV?.text = question.optionOne
        questionTwoTV?.text = question.optionTwo
        questionThreeTV?.text = question.optionThree
        questionFourTV?.text = question.optionFour
    }

    private fun defaultOptionsView()
    {
        //sets the selected options back to unselected displays when other option is selected

        val options = ArrayList<TextView>()
        questionOneTV?.let { options.add(0,it) }
        questionTwoTV?.let { options.add(1,it) }
        questionThreeTV?.let { options.add(2,it) }
        questionFourTV?.let { options.add(3,it) }

        for(option in options)
        {
            option.setTextColor(Color.parseColor("#7A8089"))
            option.typeface = Typeface.DEFAULT
            option.background = ContextCompat.getDrawable(this, R.drawable.default_option_bordar_bg)
        }
    }

    private fun selectedOptionView(tv: TextView, selectedOptionNum: Int)
    {
        defaultOptionsView()
        selectedOptionPosition = selectedOptionNum
        tv.setTextColor(Color.parseColor("#363A43")) //change the selected tv text color
        tv.setTypeface(tv.typeface, Typeface.BOLD) //make selected tv text bold
        tv.background = ContextCompat.getDrawable(this, R.drawable.selected_option_border_bg) //changes the border color of selected option
    }

    override fun onClick(view: View?) {
        when(view?.id)
        {
            R.id.optionOneTV->
                questionOneTV?.let {selectedOptionView(it, 1)}
            R.id.optionTwoTV->
                questionTwoTV?.let {selectedOptionView(it, 2)}
            R.id.optionThreeTV->
                questionThreeTV?.let {selectedOptionView(it, 3)}
            R.id.optionFourTV->
                questionFourTV?.let {selectedOptionView(it, 4)}
            R.id.submitButton-> {
                if (selectedOptionPosition == 0) {
                    currentPosition++
                    when {
                        currentPosition <= questionsList!!.size -> setQuestion()
                        else -> {
                            val intent: Intent = Intent(this, ResultActivity::class.java)
                            intent.putExtra(Constants.USERNAME, username)
                            intent.putExtra(Constants.CORRECT_ANSWERS, correctAnswers)
                            intent.putExtra(Constants.TOTAL_QUESTIONS, questionsList!!.size)
                            startActivity(intent)
                            finish()
                        }
                    }
                }
                else
                {
                    //get the current question
                    val question = questionsList?.get(currentPosition-1)

                    if(question?.correctAnswer != selectedOptionPosition) //got it wrog
                        answerView(selectedOptionPosition, R.drawable.wrog_option_border_bg)
                    else //got it right
                    {
                        correctAnswers++
                    }

                    answerView(question!!.correctAnswer, R.drawable.correct_option_border_bg)

                    if(currentPosition == questionsList!!.size)
                    {
                        submitBtn?.text = "FINISH"
                    }
                    else
                    {
                        submitBtn?.text = "NEXT QUESTION"
                    }
                    selectedOptionPosition = 0
                }
            }
        }
    }

    private fun answerView(answer: Int, drawableView: Int)
    {
        when (answer)
        {
            1 -> questionOneTV?.background = ContextCompat.getDrawable(this, drawableView)
            2 -> questionTwoTV?.background = ContextCompat.getDrawable(this, drawableView)
            3 -> questionThreeTV?.background = ContextCompat.getDrawable(this, drawableView)
            4 -> questionFourTV?.background = ContextCompat.getDrawable(this, drawableView)
        }
    }
}