﻿<%@ 
    Inherits="Castle.MonoRail.WebForms.ViewPage" 
%>

<div class="container">
    <div class="header">
        <h1>Default Home Page - @Data.Today.Date</h1>
        <h3>Well, sir, there's nothing on earth like a genuine, bona fide, Electrified, Six-car Monorail!</h3>
    </div>

	<p>Request.ServerVariables: @Request.ServerVariables.Count</p>
</div>
