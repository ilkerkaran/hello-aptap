import React, { useContext } from 'react';
import { Route, Redirect } from 'react-router-dom';
import { AuthContext } from '../Contexts/AuthContext';
import WeatherForecast from '../containers/WeatherForecasts';
import Login from '../containers/Login';
const RouterConfig = () => {

  const [token, setToken] = useContext(AuthContext);

  const securedRoutes = (<>
    <Route path="/weather" exact component={WeatherForecast} />
    <Redirect to="/weather" /></>);

  const anonymousRoutes = (<>
    <Route path="/auth/login" exact component={Login} />
    <Redirect to="/auth/login" /></>);

  return (<>
    {token ? securedRoutes : anonymousRoutes}
  </>);
}
export default RouterConfig;