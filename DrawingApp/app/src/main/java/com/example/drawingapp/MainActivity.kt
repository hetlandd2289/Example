package com.example.drawingapp

import android.Manifest
import android.app.AlertDialog
import android.app.Dialog
import android.content.Intent
import android.content.pm.PackageManager
import android.graphics.Bitmap
import android.graphics.Canvas
import android.graphics.Color
import android.media.MediaScannerConnection
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.provider.MediaStore
import android.view.View
import android.widget.*
import androidx.activity.result.ActivityResultLauncher
import androidx.activity.result.contract.ActivityResultContracts
import androidx.core.app.ActivityCompat
import androidx.core.content.ContextCompat
import androidx.core.view.get
import androidx.lifecycle.lifecycleScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import java.io.ByteArrayOutputStream
import java.io.File
import java.io.FileOutputStream

class MainActivity : AppCompatActivity()
{

    private var drawingView: DrawingView? = null
    private var currentPaintIB: ImageButton? = null
    private var customProgressDialog: Dialog? = null

    val galleryLauncher: ActivityResultLauncher<Intent> = registerForActivityResult(ActivityResultContracts.StartActivityForResult())
    {
        result ->
        if (result.resultCode == RESULT_OK && result.data != null)
        {
            val imageBG: ImageView = findViewById(R.id.backgroundIV)
            imageBG.setImageURI(result.data?.data)
        }
    }

    private val requestPermissionLauncher: ActivityResultLauncher<Array<String>> = registerForActivityResult(ActivityResultContracts.RequestMultiplePermissions())
    {
        permissions ->
        permissions.entries.forEach {
            if (it.value)
            {
                if (it.key == Manifest.permission.READ_EXTERNAL_STORAGE)
                {
                    Toast.makeText(this, "Read External Storage Permission Granted", Toast.LENGTH_LONG).show()

                    val pickIntent = Intent(Intent.ACTION_PICK, MediaStore.Images.Media.EXTERNAL_CONTENT_URI)
                    galleryLauncher.launch(pickIntent)
                }
            }
            else
            {
                if (it.key == Manifest.permission.READ_EXTERNAL_STORAGE)
                {
                    Toast.makeText(this, "Read External Storage Permission Denied", Toast.LENGTH_LONG).show()
                }
            }
        }
    }

    override fun onCreate(savedInstanceState: Bundle?)
    {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        drawingView = findViewById(R.id.drawDV)
        drawingView?.setBrushSize(20f)

        val paintColorsLL: LinearLayout = findViewById(R.id.paintColorsLL)
        currentPaintIB = paintColorsLL[0] as ImageButton
        currentPaintIB!!.setImageDrawable(ContextCompat.getDrawable(this, R.drawable.pallet_selected))

        val brushIB: ImageButton = findViewById(R.id.brushIB)//when the brush icon is clicked, pull up the 3 size buttons
        brushIB.setOnClickListener {
            showBrushSizeDialog()
        }

        val undoIB: ImageButton = findViewById(R.id.undoIB)
        undoIB.setOnClickListener{
            drawingView?.onClickUndo()
        }

        val redoIB: ImageButton = findViewById(R.id.redoIB) //I DID THIS MYSELF!!!
        redoIB.setOnClickListener{
            drawingView?.onClickRedo()
        }

        val saveIB: ImageButton = findViewById(R.id.saveIB)
        saveIB.setOnClickListener{
            if (isReadingStorageGranted())
            {
                showProgressDialog()
                lifecycleScope.launch{
                    val drawingViewFL: FrameLayout = findViewById(R.id.frameFL)
                    saveBitmapFile(getBitmapFromView(drawingViewFL))
                }
            }
        }

        val galleryIB: ImageButton = findViewById(R.id.galleryIB)
        galleryIB.setOnClickListener{
            requestStoragePermission()
        }
    }

    private fun getBitmapFromView(view: View) : Bitmap
    {
        val bm = Bitmap.createBitmap(view.width, view.height, Bitmap.Config.ARGB_8888)

        val canvas = Canvas(bm)

        val bgDraw = view.background
        if (bgDraw != null)
        {
            bgDraw.draw(canvas)
        }
        else
        {
            canvas.drawColor(Color.WHITE)
        }

        view.draw(canvas)
        return bm
    }

    //suspend marks as a coroutine
    private suspend fun saveBitmapFile(bm: Bitmap?): String
    {
        var result = ""

        withContext(Dispatchers.IO)
        {
            if (bm != null)
            {
                try
                {
                    val bytes = ByteArrayOutputStream()
                    bm.compress(Bitmap.CompressFormat.PNG, 90, bytes)

                    val fileName = File(externalCacheDir?.absoluteFile.toString() + File.separator + "DrawingApp" + System.currentTimeMillis()/1000 + ".png")

                    val outFile = FileOutputStream(fileName)//open
                    outFile.write(bytes.toByteArray())//process
                    outFile.close()//close

                    result = fileName.absolutePath

                    runOnUiThread{
                        cancelProgressDialog()
                        if (result.isNotEmpty())
                        {
                            Toast.makeText(this@MainActivity, "File Save Successful : $result", Toast.LENGTH_SHORT).show()
                            shareFile(result)
                        }
                    }
                }
                catch (e: Exception)
                {
                    result = ""
                    e.printStackTrace()
                }
            }
        }

        return result
    }

    private fun isReadingStorageGranted(): Boolean
    {
        val result = ContextCompat.checkSelfPermission(this, Manifest.permission.READ_EXTERNAL_STORAGE)
        return result == PackageManager.PERMISSION_GRANTED
    }

    private fun requestStoragePermission() {
        if(ActivityCompat.shouldShowRequestPermissionRationale(this, Manifest.permission.READ_EXTERNAL_STORAGE))
        {
            showRationaleDialog("Drawing App", "Drawing App Needs to Access Your External Storage")
        }
        else if(ActivityCompat.shouldShowRequestPermissionRationale(this, Manifest.permission.WRITE_EXTERNAL_STORAGE))
        {
            showRationaleDialog("Drawing App", "Drawing App Needs to Write to Your External Storage")
        }
        else
        {
            requestPermissionLauncher.launch(arrayOf(Manifest.permission.READ_EXTERNAL_STORAGE, Manifest.permission.WRITE_EXTERNAL_STORAGE))
        }
    }

    private fun showBrushSizeDialog() //sets size of brush based on what "button" the user clicks
    {
        val brushDialog = Dialog(this)
        brushDialog.setContentView(R.layout.dialog_brush_size)

        val smallBtn: ImageButton = brushDialog.findViewById(R.id.smallBrushIB)
        smallBtn.setOnClickListener{
            drawingView?.setBrushSize(10F)
            brushDialog.dismiss()//sends away the brush dialog
        }

        val mediumBtn: ImageButton = brushDialog.findViewById(R.id.mediumBrushIB)
        mediumBtn.setOnClickListener{
            drawingView?.setBrushSize(20F)
            brushDialog.dismiss()//sends away the brush dialog
        }

        val largeBtn: ImageButton = brushDialog.findViewById(R.id.largeBrushIB)
        largeBtn.setOnClickListener{
            drawingView?.setBrushSize(30F)
            brushDialog.dismiss()//sends away the brush dialog
        }

        brushDialog.show()//actually shows what was created above
    }

    fun paintClicked(view: View)
    {
        if (view != currentPaintIB)
        {
            //val colorTag = (view as ImageButton).tag.toString()
            val imageBtn = view as ImageButton
            drawingView?.setColor(imageBtn.tag.toString())

            imageBtn.setImageDrawable(ContextCompat.getDrawable(this, R.drawable.pallet_selected))
            currentPaintIB?.setImageDrawable(ContextCompat.getDrawable(this, R.drawable.pallet_normal))

            currentPaintIB = view
        }
    }

    private fun showRationaleDialog(title: String, message: String)
    {
        //create the custom dialog to show user
        val builder: AlertDialog.Builder = AlertDialog.Builder(this)

        //set up various attributes
        //other attributes: setIcon, setNeutralButton, setNegativeButton, setCancelable
        builder.setTitle(title)
            .setMessage(message)
            .setPositiveButton("Cancel") {dialog, _ -> dialog.dismiss()}

        //show the customized dialog
        builder.create().show()
    }

    private fun showProgressDialog()
    {
        customProgressDialog = Dialog(this)

        customProgressDialog?.setContentView(R.layout.dialog_custom_progress)

        customProgressDialog?.show()
    }

    private fun cancelProgressDialog()
    {
        if(customProgressDialog != null)
        {
            customProgressDialog?.dismiss()
            customProgressDialog = null
        }
    }

    private fun shareFile(result: String)
    {
        MediaScannerConnection.scanFile(this, arrayOf(result), null) {
            path, uri ->
            val shareIntent = Intent()
            shareIntent.action = Intent.ACTION_SEND
            shareIntent.putExtra(Intent.EXTRA_STREAM, uri)
            shareIntent.type = "image/png"
            startActivity(Intent.createChooser(shareIntent, "Share"))
        }
    }
}