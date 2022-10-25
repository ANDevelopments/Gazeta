package com.example.navhostdemo

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.TextView
import androidx.navigation.NavArgs
import androidx.navigation.NavDirections
import androidx.navigation.fragment.findNavController
import androidx.navigation.fragment.navArgs

class FragmentOne : Fragment() {


    private val args: FragmentOneArgs by navArgs()
    private lateinit var fragmentOne: View
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        fragmentOne = inflater.inflate(R.layout.fragment_one, container, false)
        val textView: TextView = fragmentOne.findViewById(R.id.myTextView)
        val back = fragmentOne.findViewById<Button>(R.id.oneBack)
        textView.text = args.message
        back.setOnClickListener {
            val nav = findNavController()
            nav.navigateUp()
        }
        return fragmentOne
    }

    companion object {
        @JvmStatic
        fun newInstance() =
            FragmentOne()
    }
}