package com.example.navhostdemo.Data.Api

import com.example.navhostdemo.Data.Api.db.ArticleDao
import com.example.navhostdemo.Models.Article
import javax.inject.Inject

class NewsRepository @Inject constructor(
    private val newsService: NewsService,
    private val articleDao: ArticleDao
    ) {
    suspend fun getNews(pageNumber: Int) =
        newsService.getHeadlines(page = pageNumber)

    fun getFavoriteArticles() = articleDao.getAllArticles()

    suspend fun addToFavorite(article: Article) = articleDao.insert(article = article)

    suspend fun deleteFromFavorite(article: Article) = articleDao.delete(article = article)
}