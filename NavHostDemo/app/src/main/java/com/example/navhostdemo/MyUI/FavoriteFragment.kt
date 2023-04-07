package com.example.navhostdemo.MyUI

import android.content.ClipData.Item
import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.os.bundleOf
import androidx.fragment.app.viewModels
import androidx.lifecycle.Observer
import androidx.navigation.findNavController
import androidx.recyclerview.widget.ItemTouchHelper
import androidx.recyclerview.widget.ItemTouchUIUtil
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.navhostdemo.Models.Article
import com.example.navhostdemo.R
import com.example.navhostdemo.databinding.FragmentFavoriteBinding
import com.google.android.material.snackbar.Snackbar
import dagger.hilt.android.AndroidEntryPoint
import kotlinx.android.synthetic.main.fragment_favorite.*
import kotlinx.android.synthetic.main.fragment_main.*
import kotlinx.coroutines.job


@AndroidEntryPoint
class FavoriteFragment : Fragment() {

    private val viewModel by viewModels<MainViewModel>()
    lateinit var newsAdapter: NewsAdapter
    private var _binding: FragmentFavoriteBinding? = null
    private val mBinding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentFavoriteBinding.inflate(layoutInflater, container, false)
        return mBinding.root
    }

   override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initAdapter()

        newsAdapter.setOnItemClickListener {
            val bundle = bundleOf("article" to it)
            view.findNavController().navigate(
                R.id.action_favoriteFragment_to_detailsFragment,
                bundle)
        }

       val itemTouchHelperCallBack = object : ItemTouchHelper.SimpleCallback(
           ItemTouchHelper.UP or ItemTouchHelper.DOWN,
           ItemTouchHelper.LEFT or ItemTouchHelper.RIGHT
       ) {
           override fun onMove(
               recyclerView: RecyclerView,
               viewHolder: RecyclerView.ViewHolder,
               target: RecyclerView.ViewHolder
           ): Boolean {
               return true
           }

           override fun onSwiped(viewHolder: RecyclerView.ViewHolder, direction: Int) {
               val position = viewHolder.adapterPosition
               val article = newsAdapter.differ.currentList[position]
               viewModel.deleteArticle(article)
               Snackbar.make(view, "Запись удалена", Snackbar.LENGTH_LONG).apply {
                   show()
               }
           }
       }

       ItemTouchHelper(itemTouchHelperCallBack).apply{
           attachToRecyclerView(news_favorites)
       }

       viewModel.getSavedArticles().observe(viewLifecycleOwner, Observer {articles ->
           newsAdapter.differ.submitList(articles)
       })
    }
    private fun initAdapter() {
        newsAdapter = NewsAdapter()
        news_favorites.apply {
            adapter = newsAdapter
            layoutManager = LinearLayoutManager(activity)
        }
    }
}

