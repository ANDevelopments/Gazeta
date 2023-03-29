package com.example.navhostdemo.MyUI

import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.os.bundleOf
import androidx.fragment.app.viewModels
import androidx.navigation.findNavController
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.navhostdemo.Models.Article
import com.example.navhostdemo.R
import com.example.navhostdemo.databinding.FragmentFavoriteBinding
import kotlinx.android.synthetic.main.fragment_main.*


class FavoriteFragment : Fragment() {

    private val viewModel by viewModels<MainViewModel>()
    private var _binding: FragmentFavoriteBinding? = null
    private val mBinding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentFavoriteBinding.inflate(layoutInflater, container, false)
        return mBinding.root
    }

//   override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
//        super.onViewCreated(view, savedInstanceState)
//        initAdapter()
//
//        newsAdapter.setOnItemClickListener {
//            val bundle = bundleOf("article" to it)
//            view.findNavController().navigate(
//                R.id.action_favoriteFragment_to_detailsFragment,
//                bundle)
//        }
//    }
//    private fun initAdapter() {
//        newsAdapter = SavedNewsAdapter()
//        news_adapter.apply {
//            adapter = newsAdapter
//            layoutManager = LinearLayoutManager(activity)
//        }
//    }
}

