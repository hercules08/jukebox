<template>
  <div class="content-block-title">
    <div class="fancy"><div :class="{fill: isFill}">{{ title }}</div></div>
  </div>
</template>

<script>

export default {
  props: ['title', 'isFill'],
};
</script>
<style scoped>

  .fancy {
    text-align: center;
  }
  .fancy div {
    display: inline-block;
    position: relative;
    padding: 10px;
    border-radius: 15px;
    color: #ff2d55;
    text-transform: capitalize;
  }
  .fancy div.fill {
      color: white;
      background: #ff2d55;
      text-transform: uppercase;
  } 
  .fancy div:before,
  .fancy div:after {
    content: "";
    position: absolute;
    height: 2px;
    background: grey;
    top: 15px;
    width: 600px;
  }
  .fancy div:before {
    right: 100%;
    margin-right: 15px;
  }
  .fancy div:after {
    left: 100%;
    margin-left: 15px;
  }
</style>