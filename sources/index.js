import Vue from 'vue';
import Framework7 from 'framework7';
import Framework7Vue from 'framework7-vue';
// import AppStore from './store/AppStore';
import Routes from './routes';
import App from './containers/App.vue';

class AppCordova {
    // Application Constructor
  initialize() {
    document.addEventListener('deviceready', this.onDeviceReady.bind(this), false);
    document.addEventListener('backbutton', this.onBackKeyDown, false);

    // Init F7 Vue Plugin
    Vue.use(Framework7Vue);

    this.app = new Vue({ // eslint-disable-line no-new
      el: '#app',
      template: '<app/>',
      // Init Framework7 by passing parameters here
      framework7: {
        root: '#app',
        routes: Routes,
        animateNavBackIcon: true,
        swipePanel: 'left',
      },
      // Register App Component
      components: {
        app: App,
      },
    });
  }

  // deviceready Event Handler
  //
  // Bind any cordova events here. Common events are:
  // 'pause', 'resume', etc.
  onDeviceReady() {
  }
  onBackKeyDown() {
    // Handle the back button
    // if (AppStore.getRouter() !== undefined) {
    //   AppStore.getRouter().back();
    // }
  }
}

const appCordova = new AppCordova();
appCordova.initialize();
