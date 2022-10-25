package com.example.navhostdemo

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.ImageButton
import android.widget.TextView
import androidx.fragment.app.Fragment
import androidx.navigation.fragment.findNavController
import androidx.navigation.fragment.navArgs
import com.example.navhostdemo.extensions.setMaxLines
import com.google.android.material.snackbar.Snackbar

class FragmentOne : Fragment() {


    private val args: FragmentOneArgs by navArgs()
    private lateinit var fragmentOne: View
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        fragmentOne = inflater.inflate(R.layout.fragment_one, container, false)
        val textView: TextView = fragmentOne.findViewById(R.id.myTextView)
        val back = fragmentOne.findViewById<Button>(R.id.oneBack)
        val shareTextButton = fragmentOne.findViewById<ImageButton>(R.id.shareTextButton)
        textView.text = args.message
        back.setOnClickListener {
            val nav = findNavController()
            nav.navigateUp()
        }
        shareTextButton.setOnClickListener {
            Snackbar
                .make(
                    fragmentOne,
                    getString(R.string.attestation_one),
                    Snackbar.LENGTH_INDEFINITE
                )
                .setAction("Ok") {

                }
                .setMaxLines(5)
                .show()
        }

        return fragmentOne
    }
}