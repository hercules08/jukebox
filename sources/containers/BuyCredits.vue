<template>
  <f7-page class="bg-white">
    <f7-navbar>
    <f7-nav-left sliding>
      <f7-link back>
        <img class="back_icon">
      </f7-link>
    </f7-nav-left>    
    <f7-nav-center sliding>Buy Credits</f7-nav-center>
    <f7-nav-right>0 Credits</f7-nav-right>
    </f7-navbar>

    <f7-block>
      <div class="buy_credits__logo">
        <img class="coins_icon">
        <p>You need credits to buy and send clips.</p>
      </div>
    </f7-block>


    <jb-fancy-block-title title="Credit Pricing"></jb-fancy-block-title>


    <f7-block inset>
      <p><f7-button big  class="button__color_5credit" fill>$5 - 5 credits</f7-button></p>
      <p><f7-button big  class="button__color_10credit" fill>$10 - 11 credits</f7-button></p>
      <p><f7-button big  class="button__color_20credit" fill>$20 - 25 credits</f7-button></p>
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

.buy_credits__logo {
  text-align: center;
}
.button__color_5credit {
  background: #C644FC !important;
}

.button__color_10credit {
  background: #EF4DB6 !important;
}

.button__color_20credit {
  background: #FF2D55 !important;
}

.coins_icon {
  width: 100px;
  height: 100px;
  content: url(./img/icons/coins.png);     
}

</style>