  // Initialize Firebase
  var config = {
    apiKey: "AIzaSyAJXwsfVag0Xwe1JFnOghY485LxCEPItt0",
    authDomain: "mytest-d3806.firebaseapp.com",
    databaseURL: "https://mytest-d3806.firebaseio.com",
    storageBucket: "mytest-d3806.appspot.com",
    messagingSenderId: "448363618207"
  };
  firebase.initializeApp(config);
  const messaging = firebase.messaging();
  messaging.requestPermission()
  .then(function(){
  	console.log('I am in here');
    
    return messaging.getToken()
  .then(function(currentToken) {
    console.log(currentToken);
  })
  .catch(function(err) {
    console.log('An error occurred while retrieving token. ', err);
    showToken('Error retrieving Instance ID token. ', err);
    setTokenSentToServer(false);
  });

  }).catch(function(err){
    console.log('Error');
  });
