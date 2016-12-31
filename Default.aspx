<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Firebase Cloud Messaging Example</title>
    <script src="https://www.gstatic.com/firebasejs/3.6.4/firebase.js"></script>
    <link rel="manifest" href="/manifest.json">
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <!-- div to display the generated Instance ID token -->
            <div id="token_div" style="display: none;">
                <h4>Instance ID Token</h4>
                <p id="token" style="word-break: break-all;"></p>
                <button onclick="deleteToken();return false;">Delete Token</button>
            </div>

            <div id="permission_div" style="display: none;">
                <h4>Needs Permission</h4>
                <button onclick="requestPermission();return false;">Request Permission</button>
            </div>
            <!-- div to display messages received by this app. -->
            <div id="messages"></div>

           
        </div>
         <script src="main.js"></script>
    </form>
</body>
</html>
