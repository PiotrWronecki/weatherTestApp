import React, { Component } from 'react';
import WeatherEmptyForm from '../weather-empty-form/weather-empty-form'

class WeatherHumidityForm extends React.Component {
    render(){
        return(
            <div>
            {this.props.humidity ?
                (<div className="row">
                    <h3 className="col-md-12" >Current humidity:</h3>
                    <span className="col-md-12">{this.props.humidity}</span>
                </div>) : <WeatherEmptyForm></WeatherEmptyForm>
            }
            </div>
        );
    }
}

export default WeatherHumidityForm;