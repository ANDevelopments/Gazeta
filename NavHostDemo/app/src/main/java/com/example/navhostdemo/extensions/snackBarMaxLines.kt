package com.example.navhostdemo.extensions

import android.widget.TextView
import com.google.android.material.snackbar.Snackbar

fun Snackbar.setMaxLines(lines: Int): Snackbar = apply {
    view.findViewById<TextView>(com.google.android.material.R.id.snackbar_text).maxLines = lines
}