package com.example.navhostdemo.MyUI

import android.view.View
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.navhostdemo.Data.Api.NewsRepository
import com.example.navhostdemo.Data.Api.db.ArticleDatabase
import com.example.navhostdemo.Models.Article
import com.example.navhostdemo.Models.NewsResponse
import com.example.navhostdemo.Resource
import dagger.hilt.android.lifecycle.HiltViewModel
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import javax.inject.Inject

@HiltViewModel
class MainViewModel @Inject constructor(private val repository: NewsRepository): ViewModel() {

    val newsLiveData: MutableLiveData<Resource<NewsResponse>> = MutableLiveData()
    var newsPage = 1

    init {
        getNews()
    }

    fun getSavedArticles() = repository.getFavoriteArticles()

//    fun getSavedArticles() = viewModelScope.launch(Dispatchers.IO) {
//        repository.getFavoriteArticles()
//    }

    fun deleteArticle(article: Article) = viewModelScope.launch(Dispatchers.IO) {
        repository.deleteFromFavorite(article = article)
    }

    private fun getNews() =
        viewModelScope.launch {
            newsLiveData.postValue(Resource.Loading())
            val response = repository.getNews(pageNumber = newsPage)
            if (response.isSuccessful) {
                response.body().let { res ->
                    newsLiveData.postValue(Resource.Success(res))
                }
            } else {
                newsLiveData.postValue(Resource.Error(message = response.message()))
            }
        }
}
