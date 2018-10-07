import React, { Component } from 'react';
import WeatherLocationForm from './weather-location-form/weather-location-form';
import WeatherTemperatureForm from './weather-temerature-form/weather-temperature-form'
import WeatherHumidityForm from './weather-humidity-form/weather-humidity-form'

class WeatherResult extends React.Component {
    render() {
        return (
            <div className="container">
                <WeatherLocationForm location={this.props.weatherResponse.location}></WeatherLocationForm>
                <WeatherTemperatureForm temperature={this.props.weatherResponse.temperature}></WeatherTemperatureForm>
                <WeatherHumidityForm humidity={this.props.weatherResponse.humidity}></WeatherHumidityForm>
            </div>
        );
    }
}

export default WeatherResult;