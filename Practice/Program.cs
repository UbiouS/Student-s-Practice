using System; 
  
class Practice { 
    static int V = 20; 
    int minDistance(int[] dist, bool[] sptSet) 
    { 
        // Initialize min value 
        int min = int.MaxValue, min_index = -1; 
  
        for (int v = 0; v < V; v++) 
            if (sptSet[v] == false && dist[v] <= min) { 
                min = dist[v]; 
                min_index = v; 
            } 
  
        return min_index; 
    } 
    void printSolution(int[] dist, int n) 
    { 
        Console.Write("Vertex     Distance " + "from Source\n"); 
        for (int i = 0; i < V; i++) 
            Console.Write(i+1 + " \t\t " + dist[i] + "\n"); 
    }
    void dijkstra(int[, ] graph, int src) 
    { 
        int[] dist = new int[V];
        bool[] sptSet = new bool[V]; 
  
        for (int i = 0; i < V; i++) { 
            dist[i] = int.MaxValue; 
            sptSet[i] = false; 
        } 
  
        dist[src] = 0; 
  
        for (int count = 0; count < V - 1; count++) {
            int u = minDistance(dist, sptSet); 
            sptSet[u] = true; 
  
            for (int v = 0; v < V; v++) 
  
                
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v]) dist[v] = dist[u] + graph[u, v]; 
        } 
  
        printSolution(dist, V); 
    } 
  
    // Driver Code 
    public static void Main() 
    { 
        
        int[, ] graph = new int[, ] { { 0, 2000, 0, 0, 2800, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0, 0 }, //1
                                      { 2000, 0, 1500, 2600, 3000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//2 
                                      { 0, 1500, 0, 2100, 0, 2000, 2300, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//3
                                      { 0, 2600, 2100, 0, 0, 2600, 2200, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //4
                                      { 2800, 3000, 0, 0, 0, 0, 1900, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //5
                                      { 0, 0, 2000, 2600, 0, 0, 1800, 2100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //6
                                      { 0, 0, 2300, 2200, 1900, 1800, 0, 0, 2700, 2400, 2200, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //7
                                      { 0, 0, 0, 0, 0, 2100, 0, 0, 0, 0, 0, 1900, 0, 0, 0, 0, 0, 0, 0, 0},//8
                                      { 0, 0, 0, 0, 0, 0, 2700, 0, 0, 0, 0, 1800, 0, 0, 0, 0, 0, 0, 0, 0},//9
                                      { 0, 0, 0, 0, 0, 0, 2400, 0, 0, 0, 0, 0, 2000, 0, 0, 0, 0, 0, 0, 0},//10
                                      { 0, 0, 0, 0, 0, 0, 2200, 0, 0, 0, 0, 2500, 2800, 2600, 2300, 0, 0, 0, 0, 0},//11
                                      { 0, 0, 0, 0, 0, 0, 0, 1900, 1800, 0, 2500, 0, 0, 0, 2200, 0, 2100, 0, 0, 0},//12
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 2000, 2800, 0, 0, 2400, 0, 0, 0, 0, 0, 1800},//13
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2600, 0, 2400, 0, 1900, 0, 0, 0, 2100, 2200},//14
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2300, 2200, 0, 1900, 0, 2600, 0, 2700, 2700, 0},//15
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2600, 0, 2900, 2000, 0, 0},//16
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2100, 0, 0, 0, 2900, 0, 2200, 0, 0},//17
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2700, 2000, 2200, 0, 2100, 0},//18
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2100, 2700, 0, 0, 2100, 0, 2500},//19
                                      { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1800, 2200, 0, 0, 0, 0, 2500, 0} }; //20
        int start = 14;
        
        Practice t = new Practice(); 
        t.dijkstra(graph, start-1); 
    } 
} 
