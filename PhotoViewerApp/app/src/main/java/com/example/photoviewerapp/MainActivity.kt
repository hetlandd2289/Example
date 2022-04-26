package com.example.photoviewerapp

import android.Manifest
import android.app.AlertDialog
import android.content.Context
import android.content.Intent
import android.content.pm.PackageManager
import android.graphics.Bitmap
import android.graphics.Canvas
import android.graphics.Color
import android.media.Image
import android.net.Uri
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.provider.MediaStore
import android.view.View
import android.widget.FrameLayout
import android.widget.ImageButton
import android.widget.ImageView
import android.widget.Toast
import androidx.activity.result.ActivityResultLauncher
import androidx.activity.result.contract.ActivityResultContract
import androidx.activity.result.contract.ActivityResultContracts
import androidx.core.app.ActivityCompat
import androidx.core.content.ContextCompat
import java.io.ByteArrayOutputStream
import java.io.File
import java.io.FileOutputStream

class MainActivity : AppCompatActivity()
{
    private var imageView: ImageView? = null
    private var rotateBtn: ImageButton? = null

    val galleryLauncher: ActivityResultLauncher<Intent> = registerForActivityResult(
        ActivityResultContracts.StartActivityForResult())
    {
            result ->
        if (result.resultCode == RESULT_OK && result.data != null)
        {
            val imageBG: ImageView = findViewById(R.id.editIV)
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

        imageView = findViewById(R.id.editIV)

        val importIB: ImageButton = findViewById(R.id.importIB)
        importIB.setOnClickListener{
            requestStoragePermission()
        }

        val saveIB: ImageButton = findViewById(R.id.saveIB)
        saveIB.setOnClickListener{
            if (isReadingStorageGranted())
            {
                val editImage: ImageView = findViewById(R.id.editIV)
                saveImageFile(getImageFromView(editImage))
            }
        }

        // rotation animation, and rotation per click, only rotates the image view tho, doesn't rotate whatever was drawn, unless zoomed out or in first but the crop is all weird
        imageView = findViewById(R.id.editIV)
        rotateBtn = findViewById(R.id.rotateIB)
        rotateBtn?.setOnClickListener { imageView?.animate()?.rotationBy(90f)?.start() }

        //val rotateIB: ImageButton = findViewById(R.id.rotateIB)
        //rotateIB.setOnClickListener {
        //    imageView?.animate()?.rotationBy(90f)?.start()
        //    //val editImage: ImageView = findViewById(R.id.editIV)
        //    //rotateImage(getImageFromView(editImage), editImage)
        //}
    }

    private fun rotateImage(bm: Bitmap, view: View)
    {
        bm.reconfigure(50, 50, Bitmap.Config.ARGB_8888)

        //view.draw(canvas)
        //view.invalidate()
        //imageView?.draw(canvas)
        //view.draw(canvas)
        //val ImageView.bitmap: Bitmap? get() = (drawable as? BitmapDrawable)?.bitmap

        val imageBG: ImageView = findViewById(R.id.editIV)
        //imageBG.scaleY = .5F
        bm.height = 1
        val canvas = Canvas(bm)
        canvas.setBitmap(bm)
        imageBG.setBackgroundColor(Color.WHITE)
        //imageBG.setImageURI(null)
        imageBG.invalidate()

        Toast.makeText(this, "bruh", Toast.LENGTH_SHORT).show()
    }

    private fun getImageFromView(view: View) : Bitmap
    {
        val image = Bitmap.createBitmap(view.width, view.height, Bitmap.Config.ARGB_8888)
        val canvas = Canvas(image)

        val imageDraw = view.background
        if (imageDraw != null)
        {
            imageDraw.draw(canvas)
        }
        else
        {
            canvas.drawColor(Color.WHITE)
        }

        view.draw(canvas)
        return image
    }

    private fun saveImageFile(bm: Bitmap?): String
    {
        var result = ""

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

                if (result.isNotEmpty())
                {
                    Toast.makeText(this@MainActivity, "File Save Successful : $result", Toast.LENGTH_SHORT).show()
                }

            }
            catch (e: Exception)
            {
                result = ""
                e.printStackTrace()
            }
        }

        return result
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

    private fun requestStoragePermission()
    {
        if(ActivityCompat.shouldShowRequestPermissionRationale(this, Manifest.permission.READ_EXTERNAL_STORAGE))
        {
            showRationaleDialog("Photo Viewer App", "Photo Viewer App Needs to Access Your External Storage")
        }
        else if(ActivityCompat.shouldShowRequestPermissionRationale(this, Manifest.permission.WRITE_EXTERNAL_STORAGE))
        {
            showRationaleDialog("Photo Viewer App", "Photo Viewer App Needs to Write to Your External Storage")
        }
        else
        {
            requestPermissionLauncher.launch(arrayOf(Manifest.permission.READ_EXTERNAL_STORAGE, Manifest.permission.WRITE_EXTERNAL_STORAGE))
        }
    }

    private fun isReadingStorageGranted(): Boolean
    {
        val result = ContextCompat.checkSelfPermission(this, Manifest.permission.READ_EXTERNAL_STORAGE)
        return result == PackageManager.PERMISSION_GRANTED
    }
}