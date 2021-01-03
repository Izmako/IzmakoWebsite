google.charts.load('current', {'packages':['corechart']});
    google.charts.setOnLoadCallback(drawChart);
  
  function drawChart() {
      var data = google.visualization.arrayToDataTable([
        ['Tarih', 'SO₂'],
        ['2004',  1],
        ['2005',  2],
        ['2006',  1],
        ['2007',  0.25]
      ]);

      var options = {
        title: 'SO₂ Oranı (μg/m³)',
        curveType: 'function',
        legend: { position: 'none' }
      };

      var chart = new google.visualization.LineChart(document.getElementById('b_chart'));

      chart.draw(data, options);
    }