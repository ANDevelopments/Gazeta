package com.example.navhostdemo

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.fragment.app.findFragment
import androidx.navigation.fragment.findNavController

class MainFragment : Fragment() {

    private lateinit var myExitText: EditText
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        val view = inflater.inflate(R.layout.fragment_main, container, false)
        val toOne = view.findViewById<Button>(R.id.toNav1)
        myExitText = view.findViewById(R.id.myEditText)
        toOne.setOnClickListener {
            if(myExitText.text.length < 3){
                Toast.makeText(context,getString(R.string.not_enough_length),Toast.LENGTH_LONG).show()

            }else{
                val action = MainFragmentDirections.actionMainFragmentToFragmentOne(myExitText.text.toString())
                findNavController().navigate(action)
            }

        }
        return view
    }

    companion object {
        @JvmStatic
        fun newInstance() =
            MainFragment()
    }
}