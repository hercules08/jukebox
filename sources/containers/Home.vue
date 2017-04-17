<template>
  <f7-page name="home">
    <f7-searchbar
      cancel-link="Cancel"
      placeholder="Search clips"
      :clear-button="true"
    ></f7-searchbar>

    <f7-block-title>POPULAR CLIPS</f7-block-title>

    <f7-block>
      <div 
        class="swiper-container swiper-3 swiper-init" 
        data-swiper='{"slidesPerView": "3"}'
      >
        <div class="swiper-wrapper popular_clips__content_center">
          <div class="swiper-slide">
            <div class="popular_clips__image-block">
              <img width="100%" src="./img/data/pop_imgres1.png" class="">
              <f7-link href="/music_player/" class="play_button"></f7-link>
            </div>
            <p class="popular_clips__title_black">Crazy in Love</p>
            <p>Beyonce</p>
          </div>
          <div class="swiper-slide">
            <div class="popular_clips__image-block">
              <img width="100%" src="./img/data/pop_imgres2.png" class="">
              <f7-link href="/music_player/" class="play_button"></f7-link>
            </div>
            <p class="popular_clips__title_black">Just Dance</p>
            <p>Lady Gaga</p>              
          </div>
          <div class="swiper-slide">
            <div class="popular_clips__image-block">
              <img width="100%" src="./img/data/pop_imgres3.png" class="">
              <f7-link href="/music_player/" class="play_button"></f7-link>
            </div>
            <p class="popular_clips__title_black">All Falls Down</p>
            <p>KanYe West</p>              
          </div>
          <div class="swiper-slide">
            <div class="popular_clips__image-block">
              <img width="100%" src="./img/data/pop_imgres1.png" class="">
              <f7-link href="/music_player/" class="play_button"></f7-link>
            </div>
            <p class="popular_clips__title_black">Crazy in Love</p>
            <p>Beyonce</p>
          </div>
          <div class="swiper-slide">
            <div class="popular_clips__image-block">
              <img width="100%" src="./img/data/pop_imgres2.png" class="">
              <f7-link href="/music_player/" class="play_button"></f7-link>
            </div>
            <p class="popular_clips__title_black">Just Dance</p>
            <p>Lady Gaga</p>              
          </div>
          <div class="swiper-slide">
            <div class="popular_clips__image-block">
              <img width="100%" src="./img/data/pop_imgres3.png" class="">
              <f7-link href="/music_player/" class="play_button"></f7-link>
            </div>
            <p class="popular_clips__title_black">All Falls Down</p>
            <p>KanYe West</p>              
          </div>          
        </div>
      </div>  
    </f7-block> 

    <jb-fancy-block-title 
      title="Categories"
    ></jb-fancy-block-title>
  
    <f7-block>
      <f7-list media-list>
        <f7-list-item
          link="#"
          media="<img width='80px' src='./img/data/cat_imgres1.png'>"
          title="Hip Hop"
          subtitle="10 Artists"
          class="category__title_font"
        ></f7-list-item>

        <f7-list-item
          link="#"
          media="<img width='80px'src='./img/data/cat_imgres2.png'>"
          title="Pop"
          subtitle="10 Artists"
          class="category__title_font"
        ></f7-list-item>

        <f7-list-item
          link="#"
          media="<img width='80px' src='./img/data/cat_imgres3.png'>"
          title="R&B"
          subtitle="10 Clips"
          class="category__title_font"
        ></f7-list-item>

      </f7-list>    
    </f7-block>
  </f7-page>
</template>

<script>
import FancyBlockTitle from '../components/FancyBlockTitle.vue';

export default {
  components: {
    'jb-fancy-block-title': FancyBlockTitle,
  },

};
</script>
<style scoped>

  .category__title_font {
    font-size: 40px;
  } 
  .popular_clips__content_center {
    text-align: center;
    align-items: center
  }
  .popular_clips__content_center p {
    margin: 0px;
  }
  .popular_clips__title_black {
    color: black;
  }
  .popular_clips__image-block {
    position: relative;
    margin: 0 3px;
  }
  .play_button {
    width: 50px;
    height: 50px;
    content: url(./img/icons/play.png);
    position: absolute;
    bottom: 10%;
    right: 10%;    
  }

</style>
