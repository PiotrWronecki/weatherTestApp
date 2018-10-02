import React, { Component } from 'react';

class WeatherResultForm extends React.Component {
    render() {
        return (
            <div className="container">
                {this.props.weatherResponse.location.city ?
                    (<div className="row">
                        <h3 className="col-md-12" >Current location</h3>
                        <span className="col-md-2">City:</span>
                        <span className="col-md-8">{this.props.weatherResponse.location.city}</span>
                        <span className="col-md-2"></span>
                        <span className="col-md-2">Country:</span>
                        <span className="col-md-8">{this.props.weatherResponse.location.country}</span>
                    </div>) : (
                        <div className="row">
                        </div>
                    )
                }
                {this.props.weatherResponse.temperature.format ?
                    (<div className="row">
                        <h3 className="col-md-12" >Current temperature:</h3>
                        <span className="col-md-12">{this.props.weatherResponse.temperature.value} {this.props.weatherResponse.temperature.format}</span>
                    </div>) : (
                        <div className="row">
                        </div>
                    )
                }
                {this.props.weatherResponse.humidity ?
                    (<div className="row">
                        <h3 className="col-md-12" >Current humidity:</h3>
                        <span className="col-md-12">{this.props.weatherResponse.humidity}</span>
                    </div>) : (
                        <div className="row">
                        </div>
                    )
                }
            </div>
        );
    }
}

export default WeatherResultForm;