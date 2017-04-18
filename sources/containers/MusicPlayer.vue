<template>
  <f7-page class="bg-white">
    <f7-navbar>
      <f7-nav-left>
        <f7-link back>
          <img class="back_icon">
        </f7-link>
      </f7-nav-left>    
      <f7-nav-center><span class="jukebox_text">JUKEBOX</span></f7-nav-center>
    </f7-navbar>

      <div class="player player__background" style="background-image:url('./img/data/player_imgres1.png');">
        <video id="video" width="0" height="0" v-on:timeupdate="onTimeUpdate">
            <source src="media/spl_024.mp3" type="audio/mp3">
        </video>
      </div>
      <div class="player__controls player__background">
        <f7-progressbar :progress="timeProgress"></f7-progressbar>
        <f7-grid no-gutter>
          <f7-col width="10">{{ currentTime }}</f7-col>
          <f7-col width="80"></f7-col>
          <f7-col width="10">{{ leftTime }}</f7-col>

        </f7-grid>

        <span style="font-size: 20px; font-weight: 400; color: black">
          Crazy in Love
        </span><br />
        <span>
          Beyonce
        </span><br />

        <f7-link id="play-pause" v-on:click="onPlayPauseClick">
          <img v-bind:class="classPlayPauseButton">
        </f7-link>

        <f7-grid no-gutter>
          <f7-col width="20"></f7-col>
          <f7-col width="10">
            <f7-label>
              <img class="sound_icon">
            </f7-label>
          </f7-col>
          <f7-col width="50">
            <f7-input type="range" min="0" max="100" step="1" value="50" v-on:input="onVolumeChange"></f7-input>


          </f7-col>
          <f7-col width="20"></f7-col>
        </f7-grid>

        <f7-button 
          id="send_button" big raised fill 
          color="blue" 
          v-on:click="onSendButtonClick"
          class="action_button"
        >Send</f7-button>

      </div>

  </f7-page>
</template>

<script>

export default {
  data() {
    return {
      timeProgress: 0,
      currentTime: '0:00',
      leftTime: '0:00',
      isPlay: false,
    };
  },
  computed: {
    classPlayPauseButton() {
      return {
        play_icon: !this.isPlay,
        pause_icon: this.isPlay,
      };
    },
  },
  methods: {
    onSendButtonClick() {
      const buttons1 = [
        {
          text: 'Send Text or iMessage',
          onClick: () => {
            this.$f7.alert('Send Text or iMessage');
          },
        },
        {
          text: 'Send E-mail',
          onClick: () => {
            this.$f7.alert('Send E-mail');
          },
        },
      ];
      const buttons2 = [
        {
          text: 'Cancel',
          color: 'red',
        },
      ];
      const groups = [buttons1, buttons2];
      this.$f7.actions('#send_button', groups);
    },
    onPlayPauseClick() {
      const video = this.$$('#video')[0];
      if (video.paused === true) {
        video.play();
        this.isPlay = true;
      } else {
        // Pause the video
        video.pause();
        this.isPlay = false;
      }
    },
    onTimeUpdate() {
      const video = this.$$('#video')[0];
      this.timeProgress = (video.currentTime * 100) / video.duration;

      let minutes = Math.floor(video.currentTime / 60);
      let seconds = Math.floor(video.currentTime) - (minutes * 60);
      let zero = seconds > 9 ? '' : '0';
      this.currentTime = `${minutes}:${zero}${seconds}`;
      const leftTime = video.duration - video.currentTime;

      minutes = Math.floor(leftTime / 60);
      seconds = Math.floor(leftTime) - (minutes * 60);
      zero = seconds > 9 ? '' : '0';
      this.leftTime = `${minutes}:${zero}${seconds}`;
    },
    onVolumeChange(value) {
      const video = this.$$('#video')[0];
      video.volume = value / 100;
    },
  },
};
</script>
<style>
  .player {
    width: 100%;
    height: 50%;
  }
  .action_button {
    position: absolute;
    bottom: 6px;
    width: 100%;
  }
  .player__controls {
    color: #6d6d72;
    text-align: center;
    position: relative;
    width: 100%;
    height: 50%;
  }
  .player__controls:before {
    content: "";
    position: fixed;
    left: 0;
    right: 0;
    z-index: -1;
    display: block;
    background-image: url('./img/player_controls.png');
      width: 100%;
      height: 35%;
    -webkit-filter: blur(85px);
    -moz-filter: blur(85px);
    -o-filter: blur(85px);
    -ms-filter: blur(85px);
    filter: blur(85px);
    opacity: 0.75;
  }
  .player__background {
    background-position: top;
    background-size: cover;
    background-repeat: no-repeat;
  }

  .play_icon {
    margin: 10px;
    width: 50px;
    height: 50px;
    content: url(./img/icons/play_control.png);    
  }

  .pause_icon {
    margin: 10px;
    width: 50px;
    height: 50px;
    content: url(./img/icons/pause_control.png);
  }

  .sound_icon {
    margin-top: 6px;
    width: 20px;
    height: 20px;
    content: url(./img/icons/sound.png);
  }



</style>
