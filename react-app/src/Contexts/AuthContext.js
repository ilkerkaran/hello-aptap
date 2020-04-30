import React, { useState, createContext } from "react";

export const AuthContext = createContext(['', () => { }]);

export default props => {
  const [token, setToken] = useState();

  return (
    <AuthContext.Provider value={[token, setToken]}>
      {props.children}
    </AuthContext.Provider>
  );
};
