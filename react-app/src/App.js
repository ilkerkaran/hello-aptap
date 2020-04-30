import React from 'react';
import {
  BrowserRouter as Router,
  Switch,
} from "react-router-dom";
import { Box } from '@material-ui/core';
import RouterConfig from './Router/RouterConfig';
import AuthContextProvider from './Contexts/AuthContext';

import './App.css';




function App() {
  return (
    <AuthContextProvider>
      <Box m="auto" marginTop="50"
        display="flex"
        width={500} height={80}
      >
        <Box m="auto">
          <Router>
            <Switch>
              <RouterConfig />
            </Switch>
          </Router>
        </Box>
      </Box>
    </AuthContextProvider>
  );
}

export default App;
