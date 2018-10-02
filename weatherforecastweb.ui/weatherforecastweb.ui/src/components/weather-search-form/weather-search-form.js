import React, { Component } from 'react';


class WeatherSearchForm extends React.Component {
    render() {
        return (
            <div className="container" >
                <div className="row">
                    <div className="col-md-12">
                        <h1 className="text-center">Please provide country and city:</h1>
                    </div>
                </div>
                <div className="row">
                    <div className="col-md-12">
                        <div className="form-group">
                            <input className="form-control" type="text" name="city" placeholder="City" onChange={this.props.setCity} ></input>
                        </div>
                        <div className="form-group">
                            <input className="form-control" type="text" name="country" placeholder="Country" onChange={this.props.setCountry}></input>
                        </div>
                        <div className="form-group">
                            <button className="form-control" onClick={this.props.onSubmit}>Check weather</button>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default WeatherSearchForm;