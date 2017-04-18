<template>
  <f7-page class="bg-white">
    <jb-fancy-block-title 
      title="Trending" 
      :isFill="true"
    ></jb-fancy-block-title>

    <template v-if="isLoaded">
      <template v-if="data.Success !== undefined && data.Success === true">
        <f7-list media-list>
          <ul>
            <jb-trend-element
              v-for="trend in data.Model"
              v-bind:trend_status="trend.TrendStatus"
              v-bind:artist="trend.Artist"
              v-bind:track="trend.Track"
            ></jb-trend-element>     
          </ul>
        </f7-list>        
      </template>
      <template v-else>
        <f7-block>
          <span>{{ data.Message }}</span>
        </f7-block>
      </template>
    </template>
  </f7-page>
</template>

<script>
import AppStore from '../store/AppStore';
import FancyBlockTitle from '../components/FancyBlockTitle.vue';
import TrendElement from '../components/Trending/TrendElement.vue';

export default {

  data() {
    return AppStore.getState().trending;
  },
  created() {
    AppStore.getTrends();
  },
  components: {
    'jb-fancy-block-title': FancyBlockTitle,
    'jb-trend-element': TrendElement,
  },
};
</script>
