/*
*  By: ,r. White Dragon (whitedragon3257) 
*  This code is the antidote to stop the darknes_worm/shadows.cs/worm 
*/
using System;
using System.IO;

namespace WormDetectionRemoval{class Program{
  static void Main(string[] args) { string folderPath = @"C:\caminho\da\pasta\alvo";
            Console.WriteLine($"Informe o caminho da pasta alvo: "): folderPath = @Console.ReadLine();
            if (Directory.Exists(folderPath)){ string[] files = Directory.GetFiles(folderPath);
                foreach (string filePath in files) {
                    if (IsWorm(filePath)){ Console.WriteLine($"Arquivo suspeito detectado: {Path.GetFileName(filePath)}. Removendo...");
                        RemoveFile(filePath); }
                    else{ Console.WriteLine($"O arquivo {Path.GetFileName(filePath)} está limpo. Nenhuma ação necessária."); } } }
            else{ Console.WriteLine("Pasta não encontrada."); } }
        static bool IsWorm(string filePath) {
            try { string fileContent = File.ReadAllText(filePath); return fileContent.Contains("darkness_worm"); }
            catch (Exception ex) { Console.WriteLine($"Erro ao verificar o arquivo {Path.GetFileName(filePath)}: {ex.Message}"); return false; } }
        static void RemoveFile(string filePath){
            try { File.Delete(filePath); Console.WriteLine($"Arquivo {Path.GetFileName(filePath)} removido com sucesso."); }
            catch (Exception ex){ Console.WriteLine($"Erro ao remover o arquivo {Path.GetFileName(filePath)}: {ex.Message}"); } } } }
