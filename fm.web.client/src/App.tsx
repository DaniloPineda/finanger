import { Component } from 'react';
import Main from './components/MainComponent'
import { Provider } from 'react-redux';
import { BrowserRouter } from "react-router-dom";
import { ConfigureStore } from './redux/configureStore';


const store = ConfigureStore(); 
class App extends Component {


  render() {
    return(
      <Provider store={store}>
        <BrowserRouter>
          <div>
            <Main />
          </div>
        </BrowserRouter>
      </Provider>
  );
  }
}

export default App;
