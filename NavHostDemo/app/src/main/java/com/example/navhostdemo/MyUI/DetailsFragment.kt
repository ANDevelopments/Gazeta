package com.example.navhostdemo.MyUI

import android.content.Intent
import android.net.Uri
import android.os.Bundle
import android.renderscript.ScriptGroup.Binding
import android.text.method.ScrollingMovementMethod
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.webkit.URLUtil
import android.widget.Toast
import androidx.core.content.ContextCompat
import androidx.fragment.app.viewModels
import androidx.navigation.fragment.navArgs
import com.bumptech.glide.Glide
import com.example.navhostdemo.R
import com.example.navhostdemo.databinding.FragmentDetailsBinding
import com.google.android.material.snackbar.Snackbar
import dagger.hilt.android.AndroidEntryPoint
import kotlinx.android.synthetic.main.fragment_details.*

@AndroidEntryPoint
class DetailsFragment : Fragment() {

    private var _binding: FragmentDetailsBinding? = null
    private val mBinding get() = _binding!!
    private val bundleArgs: DetailsFragmentArgs by navArgs()
    private val viewModel by viewModels<DetailsViewModel>()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentDetailsBinding.inflate(layoutInflater, container, false)
        return mBinding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        val articleArg = bundleArgs.article

        articleArg.let{article ->
            article.urlToImage.let {
                Glide.with(this).load(article.urlToImage).into(header_image)
            }
            mBinding.headerImage.clipToOutline = true
            mBinding.articleDetailsTitle.text = article.title
            mBinding.articleDetailsDescriptionText.text = article.description

            mBinding.articleDetailsButton.setOnClickListener{
                try{
                    Intent()
                        .setAction(Intent.ACTION_VIEW)
                        .addCategory(Intent.CATEGORY_BROWSABLE)
                        .setData(Uri.parse(takeIf { URLUtil.isValidUrl(article.url) }
                            ?.let{
                                article.url
                            }?: "https://google.com"))
                        .let {
                            ContextCompat.startActivity(requireContext(), it, null)
                        }
                } catch(e: Exception) {
                    Toast.makeText(context, "На устройстве нет браузера, который может открыть данную ссылку", Toast.LENGTH_SHORT)
                }
            }

            var i = 0

            mBinding.iconFavorite.setOnClickListener {
                if(i < 1)
                viewModel.saveFavoriteArticle(article)
                Snackbar.make(view, "Новость сохранена", Snackbar.LENGTH_SHORT).show()
                i += 1
            }

            mBinding.iconShare.setOnClickListener {
                val intent= Intent()
                intent.action=Intent.ACTION_SEND
                intent.putExtra(Intent.EXTRA_TEXT,article.url)
                intent.type="text/plain"
                startActivity(Intent.createChooser(intent,"Share To:"))
            }
        }
    }
}
