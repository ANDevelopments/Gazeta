package com.example.navhostdemo

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.fragment.app.FragmentContainerView
import androidx.navigation.NavHostController
import androidx.navigation.findNavController
import androidx.navigation.fragment.findNavController
import androidx.navigation.ui.AppBarConfiguration
import androidx.navigation.ui.setupActionBarWithNavController
import androidx.navigation.ui.setupWithNavController
import com.google.android.material.bottomnavigation.BottomNavigationView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val bottomNav = findViewById<BottomNavigationView>(R.id.bottom_navigation_tag)
        val appConfig = AppBarConfiguration(
            setOf(
                R.id.mainFragment,
                R.id.favoritesFragment
            )
        )
        val navHost = supportFragmentManager.findFragmentById(R.id.fragment_container_view_tag)
        navHost?.let {
            val nav = navHost.findNavController()
            bottomNav.setupWithNavController(nav)
            setupActionBarWithNavController(nav, appConfig)
        }
    }
}