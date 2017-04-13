<template>
  <!-- App -->
  <div id="app">

    <f7-views tabbar-through navbar-through>
      <f7-tabs animated>

        <f7-view id="home" tab active :dynamic-navbar="true">
          <f7-navbar>
            <f7-nav-center>JUKEBOX</f7-nav-center>
            <f7-nav-right>
              <f7-link>
                <img class="coins_icon">
              </f7-link>
            </f7-nav-right>
          </f7-navbar>
          <f7-pages>
            <f7-page name="home">
              <p>Page1 content</p>
            </f7-page>        
          </f7-pages>

        </f7-view>

        <f7-view id="trending" tab :dynamic-navbar="true">
          <f7-navbar>
            <f7-nav-center>TRENDING</f7-nav-center>
            <f7-nav-right>
              <f7-link>
                <img class="coins_icon">
              </f7-link>
            </f7-nav-right>
          </f7-navbar>
          <f7-pages>
            <f7-page name="trending">
              <p>Page2 content</p>
            </f7-page>        
          </f7-pages>
        </f7-view>

        <f7-view id="profile" tab :dynamic-navbar="true">
          <f7-navbar>
            <f7-nav-center>PROFILE</f7-nav-center>
            <f7-nav-right>
              <f7-link>
                <img class="coins_icon">
              </f7-link>
            </f7-nav-right>
          </f7-navbar>

          <f7-pages>
            <f7-page name="profile">
              <p>Page3 content</p>
            </f7-page>        
          </f7-pages>
        </f7-view>

      </f7-tabs>
      <f7-toolbar tabbar>
        <f7-link active tab-link="#home">
          <img class="home_icon">
        </f7-link>
        <f7-link tab-link="#trending">
          <img class="trending_icon">
        </f7-link>
        <f7-link tab-link="#profile">
          <img class="profile_icon">
        </f7-link>
      </f7-toolbar>

    </f7-views>

  </div>
</template>

<script>
export default {};
</script>

<style scoped>
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
