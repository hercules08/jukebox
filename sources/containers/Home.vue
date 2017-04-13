<template>
  <f7-page>
    <jb-fancy-block-title 
      title="Hello world!" 
      :isFill="true"
    >
    </jb-fancy-block-title>
  
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
</style>
