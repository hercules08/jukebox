<template>
  <f7-page>
    <f7-block>
      <f7-grid class="profile__header_content_center">
        <f7-col width="33">
          <p class="profile__text_bold">DAMOLA</p>
        </f7-col>
        <f7-col width="33">
          <img src="./img/data/user_damola.png" class="profile__logo_img">
        </f7-col>
        <f7-col width="33">
          <p>BALANCE</p>
          <p class="profile__text_bold">50 Coins</p>
        </f7-col>
      </f7-grid>      
    </f7-block>

    <jb-fancy-block-title title="My Clips"></jb-fancy-block-title>

    <f7-block>
      <f7-list media-list>
        <f7-list-item
          link="#"
          media="<img width='80' src='./img/data/imgres1.png'>"
          title="Started From the Bottom"
          subtitle="Drake"
        ></f7-list-item>
        <f7-list-item
          link="#"
          media="<img width='80' src='./img/data/imgres2.png'>"
          title="Just Dance"
          subtitle="Lady Gaga"
        ></f7-list-item>
        <f7-list-item
          link="#"
          media="<img width='80' src='./img/data/imgres3.png'>"
          title="Crazy in Love"
          subtitle="Beyonce"
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
<style type="text/css">
  .profile__logo_img {
    max-width: 100%;
    border-radius: 50%;
  }
  .profile__header_content_center {
    text-align: center;
    align-items: center
  }
  .profile__header_content_center p {
    margin: 0px;
    font-size: 20px;
  }

  .profile__text_bold {
    font-weight: 600;
  }

</style>