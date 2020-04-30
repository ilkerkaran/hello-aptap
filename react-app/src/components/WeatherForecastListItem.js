import React from 'react';
import { ListItem, ListItemText } from '@material-ui/core';

const WeatherForecastListItem = ({ weatherForecast }) => {
  console.log('weatherForecast', weatherForecast)
  return (<ListItem>
    <ListItemText
      primary={`${weatherForecast.temperatureC} C, ${weatherForecast.temperatureF} F`}
      secondary={weatherForecast.date}
    />
  </ListItem>)
}


export default WeatherForecastListItem;