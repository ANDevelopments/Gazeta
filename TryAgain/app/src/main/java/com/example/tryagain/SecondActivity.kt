package com.example.tryagain

import android.content.Intent
import android.os.Bundle
import android.view.ActionProvider
import android.view.View
import android.widget.Button
import androidx.appcompat.app.AppCompatActivity

import android.widget.TextView


import java.util.*


class SecondActivity : AppCompatActivity() {

    private lateinit var textViewRandom: TextView
    private lateinit var textViewLabel: TextView

    companion object {
        const val TOTAL_COUNT = "total_count"
    }



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_second)

        textViewRandom = findViewById(R.id.textview_random)
        textViewLabel = findViewById(R.id.textview_label)

        showRandomNumber()


    }


    private fun showRandomNumber() {
        val count = intent.getIntExtra(TOTAL_COUNT, 0)

        val random = Random()
        var randomInt = 0

        if(count>0){
            randomInt = random.nextInt(count + 1)
        }
        textViewRandom.text = randomInt.toString()


        textViewLabel.text = getString(R.string.random_heading, count)
    }

    fun shareButton(view: View)
    {
        val shareIntent = Intent(Intent.ACTION_SEND)
        shareIntent.type = "text/paling"
        val shareBody = "share body"
        val shareSubMenu = "Subject"
        shareIntent.putExtra(Intent.EXTRA_SUBJECT, shareBody)
        shareIntent.putExtra(Intent.EXTRA_TEXT, shareSubMenu)
        startActivity(Intent.createChooser(shareIntent, "share"))
    }
}
