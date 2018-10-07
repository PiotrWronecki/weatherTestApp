import React, { Component } from 'react';
import WeatherEmptyForm from '../weather-empty-form/weather-empty-form';

class WeatherLocationForm extends React.Component {
    render() {
        return(
            <div>
            {this.props.location.city ? (
                <div className="row">
                    <h3 className="col-md-12" >Current location</h3>
                    <span className="col-md-2">City:</span>
                    <span className="col-md-8">{this.props.location.city}</span>
                    <span className="col-md-2"></span>
                    <span className="col-md-2">Country:</span>
                    <span className="col-md-8">{this.props.location.country}</span>
                </div>
             ) : <WeatherEmptyForm></WeatherEmptyForm>}
             </div>
        );
    }
}

export default WeatherLocationForm;