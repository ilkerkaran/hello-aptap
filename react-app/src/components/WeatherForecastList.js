import React from 'react';
import { List } from '@material-ui/core';
import WeatherForecastListItem from './WeatherForecastListItem';
const WeatherForecastList = ({ weatherForecasts }) => {

  console.log('weatherForecasts', weatherForecasts)
  return (
    <List dense={true}>
      {weatherForecasts.map(w => <WeatherForecastListItem key={Math.random().toString()} weatherForecast={{ ...w }} />)}
    </List >);
}
export default WeatherForecastList;