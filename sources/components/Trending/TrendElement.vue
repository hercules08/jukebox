<template>
<li class="">
  <a href="#" class="item-link">
    <div class="item-content">
      <div class="item-media">
        <img width="50px" v-bind:src="'./img/icons/circled_chevron_'+trend_status+'.png'">
      </div>
      <div class="item-inner">
        <div class="item-title-row">
          <div class="item-title">{{ track }}</div>
        </div>
        <div class="item-subtitle">{{ artist }}</div>
      </div>
    </div>
  </a>
</li>

</template>
<script type="text/javascript">

export default {
  props: ['trend_status', 'artist', 'track'],
};
</script>

<style scoped>
</style>
