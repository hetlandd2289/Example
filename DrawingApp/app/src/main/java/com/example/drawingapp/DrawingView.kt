package com.example.drawingapp

import android.content.Context
import android.graphics.*
import android.util.AttributeSet
import android.util.TypedValue
import android.view.MotionEvent
import android.view.View
import androidx.constraintlayout.widget.ConstraintSet

class DrawingView(context: Context, attrs: AttributeSet) : View(context, attrs){

    private var vDrawPath: CustomPath? = null
    private var vCanvasBitMap: Bitmap? = null
    private var vDrawPaint: Paint? = null
    private var vCanvasPaint: Paint? = null
    private var vBrushSize: Float = 0f
    private var color = Color.BLACK
    private var canvas: Canvas? = null
    private val vPaths = ArrayList<CustomPath>() //Store the strokes so they don't get overwritten constantly
    private val vUndoPaths = ArrayList<CustomPath>()

    init {
        setUpDrawing()
    }

    fun onClickUndo()
    {
        if (vPaths.size > 0)
        {
            vUndoPaths.add(vPaths.removeAt(vPaths.size-1))
            invalidate() //redraws the entire view
        }
    }

    fun onClickRedo()
    {
        if (vUndoPaths.size > 0)
        {
            vPaths.add(vUndoPaths.removeAt(vUndoPaths.size-1))
            invalidate() //redraws the entire view
        }
    }

    private fun setUpDrawing()
    {
        vDrawPaint = Paint()
        vDrawPath = CustomPath(color, vBrushSize)

        //set up the paint attributes
        vDrawPaint!!.color = color //color
        vDrawPaint!!.style = Paint.Style.STROKE //how the "brush" functions?
        vDrawPaint!!.strokeJoin = Paint.Join.ROUND //how the strokes connect
        vDrawPaint!!.strokeCap = Paint.Cap.ROUND //how the strokes end off

        vCanvasPaint = Paint(Paint.DITHER_FLAG) //fills in the white space between strokes?

    }

    override fun onSizeChanged(w: Int, h: Int, oldw: Int, oldh: Int) {
        super.onSizeChanged(w, h, oldw, oldh)

        vCanvasBitMap = Bitmap.createBitmap(w, h, Bitmap.Config.ARGB_8888)//creates the canvas/bitmap
        canvas = Canvas(vCanvasBitMap!!)
    }

    override fun onDraw(canvas: Canvas?) {
        super.onDraw(canvas)

        canvas!!.drawBitmap(vCanvasBitMap!!, 0f, 0f, vCanvasPaint)

        for (path in vPaths)//displays all of the previous marks
        {
            vDrawPaint!!.strokeWidth = path.brushThickness
            vDrawPaint!!.color = path.color
            canvas.drawPath(path, vDrawPaint!!) //for every path saved, go through and draw back out
        }

        if(!vDrawPath!!.isEmpty) //makes the canvas actually do something
        {
            vDrawPaint!!.strokeWidth = vDrawPath!!.brushThickness
            vDrawPaint!!.color = vDrawPath!!.color
            canvas.drawPath(vDrawPath!!, vDrawPaint!!)
        }
    }

    override fun onTouchEvent(event: MotionEvent?): Boolean {
        val touchX = event?.x //touch event for the x axis
        val touchY = event?.y //touch event for the y axis

        when(event?.action)
        {
            MotionEvent.ACTION_DOWN ->
            {
                vDrawPath!!.color = color
                vDrawPath!!.brushThickness = vBrushSize

                vDrawPath!!.reset()
                if (touchX != null && touchY != null)
                    vDrawPath!!.moveTo(touchX, touchY)
            }
            MotionEvent.ACTION_MOVE ->
            {
                if (touchX != null && touchY != null)
                    vDrawPath!!.lineTo(touchX, touchY)
            }
            MotionEvent.ACTION_UP ->
            {
                vPaths.add(vDrawPath!!)
                vDrawPath = CustomPath(color, vBrushSize)
            }
            else -> return false //return if nothing else hits
        }
        invalidate() //refreshes view?
        return true
    }

    fun setBrushSize(newSize: Float)
    {
        //this adjusts brush size for screen size variance
        vBrushSize = TypedValue.applyDimension(TypedValue.COMPLEX_UNIT_DIP, newSize, resources.displayMetrics)
        vDrawPaint!!.strokeWidth = vBrushSize //sets the stroke size whenever we want
    }

    fun setColor(newColor:String)
    {
        color = Color.parseColor(newColor)
        vDrawPaint!!.color = color
    }

    internal inner class CustomPath(var color: Int, var brushThickness: Float) : Path() {

    }
}