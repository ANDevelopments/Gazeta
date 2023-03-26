package com.example.navhostdemo.Data.Api

import com.example.navhostdemo.Models.NewsResponse
import com.example.navhostdemo.Utils.Constants.Companion.API_KEY
import retrofit2.http.Query
import retrofit2.http.GET
import retrofit2.Response as Response


interface NewsService {

    // "v2/top-headlines?country=us" "v2/everything?q=Челябинск&sortBy=publishedAt"

    @GET("v2/everything?q=Челябинск&sortBy=publishedAt")
    suspend fun getHeadlines(
        @Query("page") page: Int = 1,
        @Query("apiKey") apiKey: String = API_KEY
    ) : Response<NewsResponse>
}