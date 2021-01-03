google.charts.load('current', {'packages':['corechart']});
    google.charts.setOnLoadCallback(drawChart);
  
  function drawChart() {
      var data = google.visualization.arrayToDataTable([
        ['Tarih', 'NO₂'],
        ['2004',  1500],
        ['2005',  1],
        ['2006',  1000],
        ['2007',  500]
      ]);

      var options = {
        title: 'NO₂ Oranı (μg/m³)',
        curveType: 'function',
        legend: { position: 'none' }
      };

      var chart = new google.visualization.LineChart(document.getElementById('d_chart'));

      chart.draw(data, options);
    }