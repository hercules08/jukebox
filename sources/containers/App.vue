<template>
  <!-- App -->
  <div id="app">

    <f7-views tabbar-through navbar-through>
      <f7-tabs animated>

        <f7-view id="home_view" tab active :dynamic-navbar="true">
          <f7-navbar>
            <f7-nav-center><span class="jukebox_text">JUKEBOX</span></f7-nav-center>
            <f7-nav-right>
              <f7-link href="/buy_credits/" data-view="#home_view">
                <img class="coins_icon">
              </f7-link>
            </f7-nav-right>
          </f7-navbar>
          <f7-pages>
            <jb-home></jb-home>
          </f7-pages>

        </f7-view>

        <f7-view id="trending_view" tab :dynamic-navbar="true">
          <f7-navbar>
            <f7-nav-center><span class="jukebox_text">JUKEBOX</span></f7-nav-center>
            <f7-nav-right>
              <f7-link href="/buy_credits/" data-view="#trending_view">
                <img class="coins_icon">
              </f7-link>
            </f7-nav-right>
          </f7-navbar>
          <f7-pages>
            <jb-trending></jb-trending>
          </f7-pages>
        </f7-view>

        <f7-view id="profile_view" tab :dynamic-navbar="true">
          <f7-navbar>
            <f7-nav-center>PROFILE</f7-nav-center>
            <f7-nav-right>
              <f7-link href="/buy_credits/" data-view="#profile_view">
                <img class="coins_icon">
              </f7-link>
            </f7-nav-right>
          </f7-navbar>

          <f7-pages>
            <jb-profile></jb-profile>
          </f7-pages>
        </f7-view>

      </f7-tabs>
      <f7-toolbar tabbar labels>
        <f7-link active tab-link="#home_view">
          <img class="home_icon">
          <span class="tabbar-label">Home</span>
        </f7-link>
        <f7-link tab-link="#trending_view">
          <img class="trending_icon">
          <span class="tabbar-label">Trending</span>
        </f7-link>
        <f7-link tab-link="#profile_view">
          <img class="profile_icon">
          <span class="tabbar-label">Profile</span>
        </f7-link>
      </f7-toolbar>

    </f7-views>

  </div>
</template>

<script>
import Home from './Home.vue';
import Trending from './Trending.vue';
import Profile from './Profile.vue';

export default {
  components: {
    'jb-home': Home,
    'jb-profile': Profile,
    'jb-trending': Trending,
  },

};
</script>

<style scoped>
  .jukebox_text {
    letter-spacing: 4px;
  }
  .coins_icon {
    width: 24px;
    height: 24px;
    content: url(./img/icons/coins.png);    
  }
  .home_icon {
    width: 30px;
    height: 30px;
    content: url(./img/icons/home.png);
  }
  .active > .home_icon {
    width: 30px;
    height: 30px;
    content: url(./img/icons/home_active.png);
  }

  .trending_icon {
    width: 30px;
    height: 30px;
    content: url(./img/icons/1.png);
  }
  .active > .trending_icon {
    width: 30px;
    height: 30px;
    content: url(./img/icons/2.png);
  }

   .profile_icon {
    width: 30px;
    height: 30px;
    content: url(./img/icons/profile.png);
  }
  .active > .profile_icon {
    width: 30px;
    height: 30px;
    content: url(./img/icons/profile_active.png);
  } 


</style>
