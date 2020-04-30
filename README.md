# hello-aptap
simple project contains identityServer, business api, gateway api and react app as a frontend app

#How to run
Auth.API, Gateway.API and Business.API should be running with kestrel at the same time. Assumed address of APIS following 

- Auth.API: http://localhost:5000
- Business.API: http://localhost:5001
- Gateway.API: http://localhost:8000
- React app: http://localhost:3000

TODO :
- Containerize the whole solution.
- use localStorage to store token(I haven't used it yet to be able to signout on page refresh)
