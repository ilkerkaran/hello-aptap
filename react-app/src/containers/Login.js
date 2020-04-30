import React, { useContext, useEffect } from 'react';
import axios from 'axios';
import { Button, Box } from '@material-ui/core';
import { AuthContext } from './../Contexts/AuthContext';



const Login = () => {
  const [token, setToken] = useContext(AuthContext);

  const onSigninHandler = () => {
    axios.post(
      `http://localhost:8000/api/auth/login`,
      {
        ClientId: "react-client",
        ClientSecret: "secret"
      }
    ).then(res => {
      console.log('res', res);
      setToken(res.data.access_token);
    }).catch(err => {
      console.log('err', err);

    });

  }


  return (
    <Button color="primary" onClick={onSigninHandler}>Signin</Button>
  );
}
export default Login;