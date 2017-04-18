import axios from 'axios';

axios.defaults.headers = { 'Content-Type': 'application/json' };
axios.defaults.validateStatus = status => status >= 200 && status < 500;
class AppStore {
  constructor() {
    this.f7 = undefined;
    this.state = {
      trending: {
        isLoaded: false,
        data: undefined,
      },
    };
  }

  setF7(f7) {
    this.f7 = f7;
  }

  getF7() {
    return this.f7;
  }

  getState() {
    return this.state;
  }

  getTrends() {
    axios.get('http://api.getjukebox.co/api/jukebox/gettrending?returnFail=0')
      .then((response) => {
        this.state.trending.isLoaded = true;
        this.state.trending.data = response.data;
      })
      .catch((error) => {
        this.f7.alert('Server connection error', 'JUKEBOX');
      });
  }

}

const appStore = new AppStore();

module.exports = appStore;
