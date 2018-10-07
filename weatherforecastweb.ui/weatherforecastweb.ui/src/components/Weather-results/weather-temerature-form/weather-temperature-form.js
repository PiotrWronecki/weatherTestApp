import React, { Component } from 'react';
import WeatherEmptyForm from '../weather-empty-form/weather-empty-form'

class WeatherTemperatureForm extends React.Component {
    render(){
        return (
            <div>
                {this.props.temperature.format ?
                    (<div className="row">
                        <h3 className="col-md-12" >Current temperature:</h3>
                        <span className="col-md-12">{this.props.temperature.value} {this.props.temperature.format}</span>
                    </div>) : <WeatherEmptyForm></WeatherEmptyForm>
                }
            </div>
        )
    }
}

export default WeatherTemperatureForm;