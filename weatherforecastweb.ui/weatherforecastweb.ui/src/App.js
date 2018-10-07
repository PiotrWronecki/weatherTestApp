import 'bootstrap/dist/css/bootstrap.min.css';
import React, { Component } from 'react';
import WeatherForm from './components/weather-search-form/weather-search-form';
import WeatherResultForm from './components/Weather-results/Weather-results';
import logo from './logo.svg';
import axios from 'axios';
import './App.css';

class App extends Component {
  state = {
    data : {
      location : { city: '', country : '' },
      temperature: { format:'', value:''},
      humidity:''
    },
    request : {
      city : '',
      country : ''
    }
  }

  setCity = (event) => {
    this.setState({ request : { 
      city : event.target.value,
      country : this.state.request.country  
    }
    });
  };

  setCountry = (event) => {
    this.setState({ request : { 
      city : this.state.request.city,
      country : event.target.value
    }
    });
  };

  GetWeatherInformation(event){
    var urlToService = 'http://localhost:50833/api/weather/'+ this.state.request.country +'/'+ this.state.request.city;
    axios
    .get(urlToService)
    .then(response => {
      this.setState({
        data : response.data
      })
    });  
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Weather app</h1>
        </header>
        <div className="App-intro">
          <WeatherForm onSubmit = {this.GetWeatherInformation.bind(this)} setCity = {this.setCity.bind(this)}  setCountry = {this.setCountry.bind(this)} />
          <WeatherResultForm weatherResponse = { this.state.data }  />
        </div>
      </div>
    );
  }
}

export default App;
