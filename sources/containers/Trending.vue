<template>
  <f7-page>
    <jb-fancy-block-title 
      title="Trending" 
      :isFill="true"
    ></jb-fancy-block-title>


    <f7-block>
      <f7-list media-list>
        <f7-list-item
          link="#"
          media="<img width='50px' src='./img/icons/circled_chevron_up.png'>"
          title="Bad Blood"
          subtitle="Taylor Swift"
        ></f7-list-item>

        <f7-list-item
          link="#"
          media="<img width='50px' src='./img/icons/circled_chevron_up.png'>"
          title="Started From the Bottom"
          subtitle="Drake"
        ></f7-list-item>

        <f7-list-item
          link="#"
          media="<img width='50px' src='./img/icons/circled_chevron_down.png'>"
          title="Just Dance"
          subtitle="Lady Gaga"
        ></f7-list-item>

        <f7-list-item
          link="#"
          media="<img width='50px' src='./img/icons/circled_chevron_up.png'>"
          title="Bad and Boujee"
          subtitle="Migos"
        ></f7-list-item>


        <f7-list-item
          link="#"
          media="<img width='50px' src='./img/icons/circled_chevron_down.png'>"
          title="All Falls Down"
          subtitle="KanYe West"
        ></f7-list-item>

        <f7-list-item
          link="#"
          media="<img width='50px' src='./img/icons/circled_chevron_up.png'>"
          title="Crazy in Love"
          subtitle="Beyonce"
        ></f7-list-item>

        <f7-list-item
          link="#"
          media="<img width='50px' src='./img/icons/circled_chevron_down.png'>"
          title="We Gon Be Alright!"
          subtitle="Kendrick Lamar"
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
