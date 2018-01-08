using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class AdsScript : MonoBehaviour {

	//private BannerView bannerView;

	public Text textHolder;


	private BannerView bannerView;
	private InterstitialAd interstitial;
	private RewardBasedVideoAd reward;


	string adUnitId;
	public void Start()
	{


		reward = RewardBasedVideoAd.Instance;





	}

		public void RequestBanner()
		{
			
		#if UNITY_ANDROID
		adUnitId = "ca-app-pub-3940256099942544/6300978111";
		#elif UNITY_IPHONE
		adUnitId = "ca-app-pub-3940256099942544/2934735716";
		#else
		adUnitId = "unexpected_platform";
		#endif


			// Create a Smart banner at the bottom of the screen.
			bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);


			// Create an empty ad request.
			AdRequest request = new AdRequest.Builder().Build();

			// Load the banner with the request.
			bannerView.LoadAd(request);


			textHolder.text = "Banner Requested";
		}


		public void RemoveBanner()
		{
			bannerView.Destroy ();
			textHolder.text = "Banner Deleted";
		}


		public void RequestInterstitial(){
			
			
		#if UNITY_ANDROID
		adUnitId = "ca-app-pub-3940256099942544/1033173712";
		#elif UNITY_IPHONE
		adUnitId = "ca-app-pub-3940256099942544/2934735716";
		#else
		adUnitId = "unexpected_platform";
		#endif


			//Initialize
			interstitial = new InterstitialAd (adUnitId);

			// Create an empty ad request.
			AdRequest request = new AdRequest.Builder().Build();

			// Load the banner with the request.
			this.interstitial.LoadAd(request);


			textHolder.text = "Interstitial Requested";
			


		}


		public void showInterstitial(){
			
			if (this.interstitial.IsLoaded ()) {
				textHolder.text = "Showing Interstitial";
				this.interstitial.Show ();

			} else {
				textHolder.text = "Interstitial Not Yet Loaded";
			}

		}


		public void RemoveInterstitial()
		{
			interstitial.Destroy ();
			textHolder.text = "Interstitial Deleted";
		}






		public void RequestReward(){
			
		#if UNITY_ANDROID
		adUnitId = "ca-app-pub-3940256099942544/1033173712";
		#elif UNITY_IPHONE
		adUnitId = "ca-app-pub-3940256099942544/2934735716";
		#else
		adUnitId = "unexpected_platform";
		#endif


		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();

		// Load the banner with the request.
		reward.LoadAd(request,adUnitId);
		textHolder.text = "Reward Video Requested";


		}

		public void ShowReward(){


		if (reward.IsLoaded ()) {
		textHolder.text = "Showing Reward Video";
		reward.Show ();

		} else {
		textHolder.text = "Reward Video Not Yet Loaded";
		}

		}
		
		





}
