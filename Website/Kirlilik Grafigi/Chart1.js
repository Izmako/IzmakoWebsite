
google.charts.load('current', {'packages':['corechart']});
    google.charts.setOnLoadCallback(drawChart);
    var z,z1,z2,z3;
  function drawChart() {
    z= new Date().getHours()-1;
      z3=z;
      if(z<8)
      {
        z1=z+16;
        z2=z+8;
      }
      else if(8<=z<=16)
      {
        z1=z-8;
        z2=z+8;
      }
      else
      {
        z1=z-8;
        z2=z-16;
      }
      if(z1==24)
      z1='00';
      if(z2==24)
      z2='00';
      var data = google.visualization.arrayToDataTable([
        ['Tarih', 'PM₁₀'],
        [z3+'.00',  552],
        [z2+'.00',  1],
        [z1+'.00',  1025],
        [z+'.00',  500] 
      ]);
      var options = {
        title: 'PM₁₀ Oranı (μg/m³)',
        curveType: 'function',
        legend: { position: 'none' }
      };

      var chart = new google.visualization.LineChart(document.getElementById('a_chart'));

      chart.draw(data, options);
    }

    function gunluk(z,z1,z2,z3)
    {
      z= new Date().getHours()-1;
      z3=z;
      if(z<8)
      {
        z1=z+16;
        z2=z+8;
      }
      else if(8<=z<=16)
      {
        z1=z-8;
        z2=z+8;
      }
      else
      {
        z1=z-8;
        z2=z-16;
      }
      if(z1==24)
      z1='00';
      if(z2==24)
      z2='00';
    }