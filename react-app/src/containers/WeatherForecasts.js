import React, { useState, useEffect, useContext } from 'react';
import axios from 'axios'
import { AuthContext } from './../Contexts/AuthContext';
import WeatherForecastList from '../components/WeatherForecastList'
const WeatherForecast = () => {
  const [weatherForecasts, setWeatherForecasts] = useState([]);
  const token = useContext(AuthContext)[0];
  useEffect(() => {
    axios.get(
      `http://localhost:8000/api/business/weatherforecast`,
      {
        headers: { Authorization: `Bearer ${token}` }
      }
    ).then(res => {
      console.log('weatherforecast-res', res);
      setWeatherForecasts(res.data);
    }).catch(err => {
      console.log('err', err);
    });
  }, [token])
  return (<WeatherForecastList weatherForecasts={weatherForecasts} />)
}


export default WeatherForecast;