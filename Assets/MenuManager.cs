using UnityEngine;
using UnityEngine.SceneManagement; // Penting untuk pindah scene

public class MenuManager : MonoBehaviour
{
    // Fungsi ini akan dipanggil oleh tombol 'MULAI GAME'
    public void StartGame()
    {
        Debug.Log("MULAI GAME diklik. Memuat tutorscene...");

        // Nama di bawah harus sama persis dengan nama file di folder Scenes: tutorscene
        SceneManager.LoadScene("tutorscene");
    }

    // Fungsi ini akan dipanggil oleh tombol 'PENGATURAN'
    public void OpenOptions()
    {
        Debug.Log("PENGATURAN diklik. Menampilkan panel pengaturan...");
    }

    // Fungsi ini akan dipanggil oleh tombol 'CREDITS'
    public void OpenCredits()
    {
        Debug.Log("CREDITS diklik. Menampilkan panel kredit...");
    }

    // Fungsi ini akan dipanggil oleh tombol 'KELUAR'
    public void ExitGame()
    {
        Debug.Log("KELUAR diklik. Menutup aplikasi...");
        Application.Quit(); // Hanya bekerja saat sudah jadi aplikasi (Build)
    }
}