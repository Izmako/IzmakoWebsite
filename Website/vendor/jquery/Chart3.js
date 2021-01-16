google.charts.load('current', {'packages':['corechart']});
    google.charts.setOnLoadCallback(drawChart);
  
  function drawChart() {
      var data = google.visualization.arrayToDataTable([
        ['Tarih', 'O₃'],
        ['2004',  5],
        ['2005',  2],
        ['2006',  6.25],
        ['2007',  1]
      ]);

      var options = {
        title: 'O₃ Oranı (μg/m³)',
        curveType: 'function',
        legend: { position: 'none' }
      };

      var chart = new google.visualization.LineChart(document.getElementById('c_chart'));

      chart.draw(data, options);
    }